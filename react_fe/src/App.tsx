import { BrowserRouter as Router } from 'react-router-dom'
import AppRoutes from './routes'
import Footer from './components/common/Footer'
import Header from './components/common/Header'
import { createTheme, ThemeProvider } from '@mui/material'
import { FetchProvider } from './contexts/SearchBoxFetchContext'

const darkTheme = createTheme({
  palette: {
    mode: 'dark'
  }
})

function App() {
  return (
    <>
      <ThemeProvider theme={darkTheme}>
        <FetchProvider>
          <Router>
            <Header />
            <div className="main">
              <AppRoutes />
            </div>
            <Footer />
          </Router>
        </FetchProvider>
      </ThemeProvider>
    </>
  )
}

export default App
