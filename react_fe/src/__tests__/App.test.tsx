import { mockFetch } from '../__mocks__/mock-fetch'
import 'intersection-observer'
import '@testing-library/jest-dom'
import { render } from '@testing-library/react'
import App from '../App'

test('demo', () => {
  expect(true).toBe(true)
})

test('Render the main page', () => {
  window.fetch = mockFetch('')
  render(<App />)
  expect(true).toBeTruthy()
})
