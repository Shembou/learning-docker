import { Button, TextField } from '@mui/material'
import { useState } from 'react'
import styled from 'styled-components'
import { IShowInput } from '../../../types/IShowInput'
import { useNavigate } from 'react-router-dom'

export default function AddShow() {
  const navigate = useNavigate()

  const [inputValues, setInputValues] = useState<IShowInput>({
    poster: new URL('http://localhost/3000'),
    title: 'The super duper best in the world movie ever created',
    actors: ['Josh', 'Jessica'],
    awards: 'Nobel Prize and shit',
    country: 'Poland',
    director: 'Me',
    genre: ['Action', 'Drama'],
    images: [new URL('http://localhost/3000')],
    imdbRating: 6.9,
    imdbVotes: 69,
    language: 'polish',
    metascore: 69,
    plot: 'There is no plot and its beautiful',
    rated: 'pegi 18',
    runtime: '120 mins',
    type: 0,
    writer: 'Jessica',
    year: '2028'
  })

  const handleChange = ({
    target: { name, value }
  }: {
    target: { name: string; value: string }
  }) => {
    setInputValues(prevValues => ({
      ...prevValues,
      [name]: value
    }))
  }

  const handleSubmit = (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault()

    fetch(`/api/shows`, {
      method: 'POST',
      body: JSON.stringify(inputValues),
      headers: {
        'Content-Type': 'application/json'
      }
    })
      .then(res => {
        console.log(res)
        navigate('/')
        return res.json()
      })
      .catch(err => {
        console.log(err)
        return
      })
  }

  return (
    <Form onSubmit={handleSubmit}>
      {Object.keys(inputValues).map(key => {
        const value = inputValues[key as keyof IShowInput]
        return (
          <TextField
            key={key}
            name={key}
            label={key.charAt(0).toUpperCase() + key.slice(1)}
            value={value?.toString() || ''}
            onChange={handleChange}
            color="secondary"
            fullWidth
            margin="normal"
          />
        )
      })}
      <Button type="submit">AddMovie</Button>
    </Form>
  )
}

const Form = styled.form`
  display: flex;
  flex-direction: column;
  gap: 20px;
  background-color: var(--gray-200);
  padding: 20px;
  border-radius: 8px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
  color: #818181;
`
