import styled from 'styled-components'
import { useFetchContext } from '../../contexts/SearchBoxFetchContext'
import { CircularProgress } from '@mui/material'

export default function CardsLoaderWrapper({ children }: { children: JSX.Element }) {
  const fetchContext = useFetchContext()

  return fetchContext.fetch ? (
    <Div>
      <CircularProgress className="loader" />
      <div className="content">{children}</div>
    </Div>
  ) : (
    <Section>{children}</Section>
  )
}

const Div = styled.div`
  position: relative;
  .loader {
    position: sticky;
    top: 200px;
    left: 50%;
    transform: translateX(-50%);
    z-index: 100;
  }
  .content {
    opacity: 0.5;
    pointer-events: none;
  }
`

const Section = styled.section`
  display: flex;
  flex-wrap: wrap;
  gap: 20px;
  justify-content: center;
  padding: 20px;
`
