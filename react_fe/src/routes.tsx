import { Routes, Route } from 'react-router-dom'
import Home from './components/home/Home'
import Show from './components/show/Show'
import Shows from './components/shows/Shows'
import AddShow from './components/shows/AddShow/AddShow'

export default function AppRoutes() {
  return (
    <Routes>
      <Route path="/" element={<Home />} />
      <Route path="/shows" element={<Shows />} />
      <Route path="/shows/:showId" element={<Show />} />
      <Route path="/shows/add" element={<AddShow />} />
    </Routes>
  )
}
