import SearchIcon from '@mui/icons-material/Search'
import { Box, Button, TextField } from '@mui/material'
import { useSearchParams } from 'react-router-dom'
import styled from 'styled-components'
import { useFetchContext } from '../../contexts/SearchBoxFetchContext'
import { useRef } from 'react'
import { CSSTransition } from 'react-transition-group'
import { useInViewOnce } from '../../hooks/useInViewHooks'

const CardsInteractions = () => {
  const [searchParams, setSearchParams] = useSearchParams()
  const ref = useRef<HTMLInputElement | null>(null)
  const actionWrapperRef = useRef<HTMLDivElement | null>(null)
  const isVisible = useInViewOnce(actionWrapperRef, 0.1)

  function handleOnBlur(event: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) {
    searchParams.set('searchQuery', event.target.value)
    setSearchParams(searchParams)
    fetchContext.setFetch(true)
  }

  function handleKeyDown(event: React.KeyboardEvent) {
    if (event.key == 'Enter' && ref.current) {
      ref.current.blur()
    }
  }

  const fetchContext = useFetchContext()

  return (
    <ActionsWrapper>
      <CSSTransition nodeRef={actionWrapperRef} classNames="item" timeout={1000} in={isVisible}>
        <ActionWrapper ref={actionWrapperRef}>
          <Box sx={{ display: 'flex', alignItems: 'flex-end' }}>
            <SearchIcon sx={{ color: 'white', mr: 1, my: 0.5 }} />
            <TextField
              id="search-box"
              label="With sx"
              onBlur={event => handleOnBlur(event)}
              onKeyDown={event => handleKeyDown(event)}
              inputRef={ref}
            />
          </Box>
        </ActionWrapper>
      </CSSTransition>
      <ActionWrapper>
        <Button href="/shows/add">Add show</Button>
      </ActionWrapper>
    </ActionsWrapper>
  )
}
const ActionWrapper = styled.div`
  display: grid;
  height: min-content;
  align-self: center;
  > input {
    color: white;
  }
  &.item-enter {
    opacity: 0;
  }
  &.item-enter-active {
    opacity: 1;
    transition: opacity 1000ms;
  }
`

const ActionsWrapper = styled.div`
  display: flex;
  gap: 30px;
`
export default CardsInteractions
