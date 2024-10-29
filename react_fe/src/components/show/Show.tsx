import { useEffect, useState } from 'react'
import styled from 'styled-components'
import { type IShow } from '../../types/IShow'
import { Link, useParams } from 'react-router-dom'
import { generateMetascoreColor } from '../../utils/generateMetascoreColor'
import Breadcrumbs from '../common/Breadcrumbs/Breadcrumbs'

function Show() {
  const { showId } = useParams()
  const [show, setShow] = useState<IShow | null>(null)

  useEffect(() => {
    fetch(`/api/shows/${showId}`)
      .then(res => {
        return res.json()
      })
      .then((data: IShow) => {
        console.log(data)
        console.log(showId)
        setShow(data)
      })
  }, [])

  const breadcrumbs = [
    {
      title: 'Home',
      link: '/'
    },
    {
      title: 'Shows',
      link: '/shows'
    },
    {
      title: `${show?.title}`,
      link: `${showId}`
    }
  ]

  return (
    <>
      <Breadcrumbs breadcrumbs={breadcrumbs} />
      <Section>
        {show && (
          <div className="wrapper">
            <div className="poster">
              <img src={show.poster as unknown as string} alt="Show Poster" />
            </div>
            <div className="info">
              <h2 className="title">{show.title}</h2>
              {show.metascore != 0 && (
                <p className={`metascore ${generateMetascoreColor(show.metascore)}`}>
                  {show.metascore}
                </p>
              )}
              {show.imdbRating != 0 && (
                <p className="rating">
                  IMDb Rating: <span>{show.imdbRating}</span> / 10
                </p>
              )}
              <p className="year">{show.year}</p>
              {show.genre.map((x, index) => (
                <Link key={index} to={`/shows/?searchQuery=${x}`}>
                  {x}
                </Link>
              ))}
              <p className="runtime">{show.runtime}</p>
              <p className="director">Director: {show.director}</p>
              {show.actors.map((x, index) => (
                <Link key={index} to={`/shows/?searchQuery=${x}`}>
                  {x}
                </Link>
              ))}
              <p className="plot">{show.plot}</p>
            </div>
          </div>
        )}
      </Section>
    </>
  )
}

export default Show

const Section = styled.section`
  display: flex;
  background-color: var(--gray-200);
  padding: 20px;
  border-radius: 8px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
  color: #818181;

  .wrapper {
    display: flex;
    gap: 20px;
  }
  .info {
    display: grid;
    justify-items: center;
    align-items: center;
  }

  .metascore {
    padding: 8px;
    width: clamp(10px, 20px, 30px);
    border-radius: 3px;
    height: clamp(10px, 20px, 30px);
    text-align: center;
    margin: unset;
    &.green {
      background-color: green;
      color: white;
    }
    &.yellow {
      background-color: yellow;
      color: black;
    }
    &.red {
      background-color: red;
      color: black;
    }
  }

  .poster img {
    width: 300px;
    height: 450px;
    border-radius: 8px;
  }

  h2 {
    font-size: 32px;
    margin-bottom: 10px;
  }

  p {
    margin-bottom: 10px;
  }

  .rating span {
    font-weight: bold;
    color: #f5c518;
  }
`
