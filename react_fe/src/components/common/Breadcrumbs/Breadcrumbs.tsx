import styled from 'styled-components'
import { IBreadcrumb } from './IBreadcrumb'
import { Link } from 'react-router-dom'

export default function Breadcrumbs({ breadcrumbs }: { breadcrumbs: IBreadcrumb[] }) {
  console.log(breadcrumbs)
  return (
    <>
      <Breadcrumb aria-label="Breadcrumb" className="breadcrumb">
        <ol>
          {breadcrumbs.map((breadcrumb, i) =>
            i + 1 != breadcrumbs.length ? (
              <li key={i}>
                <Link to={breadcrumb.link}>{breadcrumb.title}</Link>
              </li>
            ) : (
              <li key={i}>
                <Link to={breadcrumb.link} aria-current="page" aria-disabled="true">
                  {breadcrumb.title}
                </Link>
              </li>
            )
          )}
        </ol>
      </Breadcrumb>
    </>
  )
}

const Breadcrumb = styled.nav`
  padding: 0.8em 1em;
  border-radius: 4px;
  justify-self: flex-start;
  padding-top: 20px;
  margin-left: 150px;

  a {
    color: white;
  }

  ol {
    margin: 0;
    padding-left: 0;
    list-style: none;
  }

  li {
    display: inline;
  }

  li + li::before {
    display: inline-block;
    margin: 0 0.25em;
    transform: rotate(15deg);
    border-right: 0.1em solid white;
    height: 0.8em;
    content: '';
  }

  [aria-current='page'] {
    color: #000;
    font-weight: 700;
    text-decoration: none;
  }

  [aria-disabled='true'] {
    pointer-events: none;
    color: gray;
  }
`
