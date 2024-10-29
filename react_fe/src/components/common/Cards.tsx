import styled from 'styled-components'
import Card from './Card'
import SlideWithRandomizedTime from '../HOCs/SlideWithRandomizedTime'
import { SlideType } from '../../enums/SlideType'
import { useEffect, useState } from 'react'
import { useSearchParams } from 'react-router-dom'
import { IShow } from '../../types/IShow'
import { useFetchContext } from '../../contexts/SearchBoxFetchContext'
import CardsLoaderWrapper from '../HOCs/CardsLoaderWrapper'

const Cards = () => {
  const [searchParams] = useSearchParams()
  const [shows, setShows] = useState<IShow[] | null>(null)

  const fetchContext = useFetchContext()

  useEffect(() => {
    fetch(`/api/shows/?${searchParams}`)
      .then(res => {
        return res.json()
      })
      .then((data: IShow[]) => {
        setShows(data)
        fetchContext.setFetch(false)
      })
  }, [fetchContext.fetch])

  return (
    <CardsLoaderWrapper>
      <Section>
        {shows &&
          shows.map((show, i) => (
            <SlideWithRandomizedTime
              key={i}
              passedSlideType={SlideType.SlideInFromTop}
              minTime={1}
              maxTime={1.2}
            >
              {<Card>{show}</Card>}
            </SlideWithRandomizedTime>
          ))}
      </Section>
    </CardsLoaderWrapper>
  )
}

const Section = styled.section`
  display: flex;
  flex-wrap: wrap;
  gap: 20px;
  justify-content: center;
  padding: 20px;
`

export default Cards
