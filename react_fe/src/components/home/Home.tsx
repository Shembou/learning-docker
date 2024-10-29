import styled from 'styled-components'
import CardsInteractions from '../common/CardsInteractions'
import Cards from '../common/Cards'

function Home() {
  return (
    <Section>
      <CardsInteractions />
      <Cards />
    </Section>
  )
}

export default Home

const Section = styled.section`
  display: flex;
  flex-wrap: wrap;
  gap: 20px;
  justify-content: center;
  padding: 20px;
`
