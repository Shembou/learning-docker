export function generateMetascoreColor(metascore: number) {
  if (metascore > 60) {
    return 'green'
  } else if (metascore > 30) {
    return 'yellow'
  }
  return 'red'
}
