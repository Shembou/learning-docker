import { createContext, useState, useEffect, useContext, useMemo } from 'react'

// Create the context outside of the component

const FetchContext = createContext<{
  fetch: boolean
  setFetch: React.Dispatch<React.SetStateAction<boolean>>
}>({
  fetch: false,
  setFetch: () => {}
})

export function FetchProvider({
  data = false,
  children
}: {
  data?: boolean
  children: React.ReactNode
}) {
  const [fetch, setFetch] = useState<boolean>(false)

  useEffect(() => {
    if (data) {
      setFetch(data)
    }
  }, [data])

  const value = useMemo(() => ({ fetch, setFetch }), [fetch])

  return <FetchContext.Provider value={value}>{children}</FetchContext.Provider>
}

// Custom hook for easier use of the context
export function useFetchContext() {
  return useContext(FetchContext)
}
