export default {
  preset: 'ts-jest',
  testEnvironment: 'jest-environment-jsdom',
  transform: {
    '^.+\\.tsx?$': 'ts-jest'
  },
  globals: {
    'ts-jest': {
      tsconfig: 'tsconfig.app.json' // Use your custom tsconfig
    }
  },
  moduleFileExtensions: ['ts', 'tsx', 'js', 'jsx']
}
