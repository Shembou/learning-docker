import { memo } from 'react'
import { Link } from 'react-router-dom'
import styled from 'styled-components'

const HeaderContainer = styled.header`
  display: grid;
  background-color: var(--gray-200);
  text-align: center;
  grid-template-columns: repeat(5, 1fr);
`

const NavBar = styled.nav`
  display: grid;
  justify-content: space-around;
  grid-template-columns: repeat(2, 1fr);
`

const NavItem = styled(Link)`
  color: white;
  text-decoration: none;
  font-size: 1.2rem;
  align-self: center;

  &:hover {
    text-decoration: underline;
  }
`

const Header = memo(() => {
  return (
    <HeaderContainer>
      <h1>My Website</h1>
      <NavBar>
        <NavItem to="/" relative="path">
          Home
        </NavItem>
        <NavItem to="/shows" relative="path">
          Shows
        </NavItem>
      </NavBar>
    </HeaderContainer>
  )
})

export default Header
