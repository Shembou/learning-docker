import styled from 'styled-components'

const FooterContainer = styled.footer`
  background-color: #333;
  padding: 1rem;
  text-align: center;
`

const FooterText = styled.p`
  margin: 0;
  font-size: 0.9rem;
`

const Footer = () => {
  return (
    <FooterContainer>
      <FooterText>&copy; {new Date().getFullYear()} My Website. All rights reserved.</FooterText>
    </FooterContainer>
  )
}

export default Footer
