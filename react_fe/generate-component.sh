#!/bin/bash

GENERATE_COMPONENT_cmdname=${0##*/}

usage() {
    cat << USAGE >&2
Usage:
    $GENERATE_COMPONENT_cmdname [Path] [ComponentName] [--wrapper <WrapperName>] [--htmlElement <HtmlElement>] [--types <ComponentTypes>]
    Path                        Relative path to generated file
    ComponentName               Name of the component

    --wrapper                   Name of the styled wrapper (default: Section)
    --htmlElement               Type of the wrapper to generate (default: section)
    --types                     Comma-separated list of component props in the format propName:propType
USAGE
    exit 1
}

# Default values
STYLED_COMPONENT_NAME="Section"
HTML_ELEMENT="section"

TARGET_PATH=$1
COMPONENT_NAME=$2

if [ -z "$TARGET_PATH" ] || [ -z "$COMPONENT_NAME" ]; then
  echo "Error: Path and Component name are required."
  usage
fi

COMPONENT_DIR="$PWD/$TARGET_PATH/$COMPONENT_NAME"
GENERATED_TYPE_NAME="I$COMPONENT_NAME"

COMPONENT_PROPS=""
TS_INTERFACE_PROPS=""
TS_COMPONENT_PROPS=""

shift 2
while [[ $# -gt 0 ]]; do
    case "$1" in
        --wrapper)
            STYLED_COMPONENT_NAME="$2"
            shift 2
            ;;
        --htmlElement)
            HTML_ELEMENT="$2"
            shift 2
            ;;
        --types)
            COMPONENT_PROPS="$2"
            shift 2
            ;;
        --help)
            usage
            ;;
        *)
            echo "Unknown option: $1"
            usage
            ;;
    esac
done

if [ -n "$COMPONENT_PROPS" ]; then
    IFS=',' read -ra PROP_ARRAY <<< "$COMPONENT_PROPS"
    for (( i=0; i<${#PROP_ARRAY[@]}; i++ )); do
        PROP=$(echo "${PROP_ARRAY[$i]}")
        PROP_NAME=$(echo $PROP | cut -d: -f1)
        PROP_TYPE=$(echo $PROP | cut -d: -f2)

        TS_INTERFACE_PROPS="$TS_INTERFACE_PROPS  $PROP_NAME: $PROP_TYPE\n"
        if [ $i -eq $(( ${#PROP_ARRAY[@]} - 1 )) ]; then
            TS_COMPONENT_PROPS="$TS_COMPONENT_PROPS$PROP_NAME"
        else
            TS_COMPONENT_PROPS="$TS_COMPONENT_PROPS$PROP_NAME, "
        fi
    done
fi

mkdir -p "$COMPONENT_DIR"

cat <<EOL > "$COMPONENT_DIR/$COMPONENT_NAME.tsx"
import styled from 'styled-components'
$(if [ -n "$COMPONENT_PROPS" ]; then echo "import { ${GENERATED_TYPE_NAME} } from './${GENERATED_TYPE_NAME}'"; fi)
const ${COMPONENT_NAME} = ($([ -n "$TS_COMPONENT_PROPS" ] && echo "{ $TS_COMPONENT_PROPS }: ${GENERATED_TYPE_NAME}" || echo "")) => {
  return <${STYLED_COMPONENT_NAME}>{/* TODO */}</${STYLED_COMPONENT_NAME}>
}

const ${STYLED_COMPONENT_NAME} = styled.${HTML_ELEMENT}\`
  /* Add your styles here */
\`

export default ${COMPONENT_NAME}
EOL

if [ -n "$TS_INTERFACE_PROPS" ]; then
printf "export interface ${GENERATED_TYPE_NAME} {\n" > "$COMPONENT_DIR/${GENERATED_TYPE_NAME}.ts"
printf "$TS_INTERFACE_PROPS" >> "$COMPONENT_DIR/${GENERATED_TYPE_NAME}.ts"
printf "}\n" >> "$COMPONENT_DIR/${GENERATED_TYPE_NAME}.ts"
fi

cat <<EOL > "$COMPONENT_DIR/$COMPONENT_NAME.test.tsx"
import { render } from '@testing-library/react'
import ${COMPONENT_NAME} from './${COMPONENT_NAME}'

test('renders ${COMPONENT_NAME} component', () => {
  const { container } = render(<${COMPONENT_NAME} />)
  expect(container).toBeInTheDocument()
})
EOL

echo "${COMPONENT_NAME} component generated successfully at ${COMPONENT_DIR}."
