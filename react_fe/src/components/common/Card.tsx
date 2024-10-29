import styled from 'styled-components'
import { IShow } from '../../types/IShow'
import { Link } from 'react-router-dom'
import { useRef } from 'react'

export default function Card({ children }: { children: IShow }) {
  const ref = useRef(null)

  return (
    <Show to={`/shows/${children.showId}`} ref={ref}>
      <img
        alt={`${children.title} Poster`}
        className="movie-poster"
        src={children.poster! as unknown as string}
      />
      <div className="movie-info">
        <h2 className="movie-title">{children.title}</h2>
        <p className="movie-rating">
          <strong>Rated:</strong> {children.rated}
        </p>
        <p className="movie-imdbRating">
          <strong>IMDb Rating:</strong> {children.imdbRating}
        </p>
        {children.metascore != 0 && (
          <p className="movie-metascore">
            <strong>Metascore:</strong> {children.metascore}
          </p>
        )}
      </div>
    </Show>
  )
}

const Show = styled(Link)`
  display: flex;
  flex-direction: column;
  align-items: center;
  background-color: #ffffff;
  border-radius: 10px;
  overflow: hidden;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
  transition:
    transform 0.3s ease,
    box-shadow 0.3s ease;
  width: 300px;
  padding-bottom: 10px;

  &:hover {
    transform: translateY(-10px);
    box-shadow: 0 6px 12px rgba(0, 0, 0, 0.3);
    cursor: pointer;
  }

  .movie-poster-section {
    display: flex;
    flex-wrap: wrap;
    gap: 20px;
    justify-content: center;
    padding: 20px;
  }

  .movie-card {
    display: flex;
    flex-direction: column;
    align-items: center;
    background-color: #ffffff;
    border-radius: 10px;
    overflow: hidden;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
    transition:
      transform 0.3s ease,
      box-shadow 0.3s ease;
    width: 300px;
    padding-bottom: 10px;

    &:hover {
      transform: translateY(-10px);
      box-shadow: 0 6px 12px rgba(0, 0, 0, 0.3);
      cursor: pointer;
    }
  }

  .movie-poster {
    width: 100%;
    height: 400px;
    object-fit: cover;
    border-bottom: 2px solid #ddd;
  }

  .movie-info {
    padding: 15px;
    text-align: center;

    .movie-title {
      font-size: 1.25rem;
      font-weight: bold;
      margin: 10px 0;
      color: #000;
    }

    .movie-rating,
    .movie-imdbRating,
    .movie-metascore {
      font-size: 0.9rem;
      margin: 5px 0;
      color: #555;
    }

    .movie-rating strong,
    .movie-imdbRating strong,
    .movie-metascore strong {
      color: #000;
    }
  }

  @media screen and (max-width: 768px) {
    .movie-card {
      width: 100%;
      max-width: 300px;
    }
  }
`
