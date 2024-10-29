import styled from 'styled-components'
import { SlideType } from '../../enums/SlideType'
import randomizeTime from '../../utils/randomizeTime'

export default function SlideWithRandomizedTime({
  passedSlideType,
  minTime = 0.5,
  maxTime = 1.5,
  children
}: {
  passedSlideType: SlideType
  minTime?: number
  maxTime?: number
  children: JSX.Element
}) {
  const time = randomizeTime({ minTime, maxTime })

  return (
    <Slide $slideType={passedSlideType} $passedTime={time}>
      {children}
    </Slide>
  )
}

const Slide = styled.div<{
  $slideType?: SlideType
  $passedTime?: number
}>`
  @keyframes slideInFromTop {
    0% {
      transform: translateY(-10%);
      opacity: 0;
    }
    60% {
      transform: translateY(0%);
      opacity: 1;
    }

    100% {
      transform: translateY(0%);
      opacity: 1;
    }
  }

  @keyframes slideInFromBottom {
    0% {
      transform: translateY(10%);
      opacity: 0;
    }
    60% {
      transform: translateY(0%);
      opacity: 1;
    }
    100% {
      transform: translateY(0%);
      opacity: 1;
    }
  }
  @keyframes slideInFromRight {
    0% {
      transform: translateX(10%);
      opacity: 0;
    }
    60% {
      transform: translateX(0%);
      opacity: 1;
    }
    100% {
      transform: translateX(0%);
      opacity: 1;
    }
  }
  @keyframes slideInFromLeft {
    0% {
      transform: translateX(-10%);
      opacity: 0;
    }
    60% {
      transform: translateX(0%);
      opacity: 1;
    }
    100% {
      transform: translateX(0%);
      opacity: 1;
    }
  }
  display: flex;
  animation: ${props => props.$passedTime}s ease-in-out ${props => props.$slideType};
`
