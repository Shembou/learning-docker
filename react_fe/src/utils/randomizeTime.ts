export default function randomizeTime({ minTime, maxTime }: { minTime: number; maxTime: number }) {
  return Math.pow(Math.random() * (maxTime - minTime) + minTime, 2)
}
