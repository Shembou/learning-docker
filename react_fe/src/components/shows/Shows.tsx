import Breadcrumbs from '../common/Breadcrumbs/Breadcrumbs'

import Cards from '../common/Cards'
import CardsInteractions from '../common/CardsInteractions'

const Shows = () => {
  const breadcrumbs = [
    {
      title: 'Home',
      link: '/'
    },
    {
      title: 'Shows',
      link: '/shows'
    }
  ]

  return (
    <>
      <Breadcrumbs breadcrumbs={breadcrumbs} />
      <CardsInteractions />
      <Cards />
    </>
  )
}
export default Shows
