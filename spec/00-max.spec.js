import { max } from '../00-max.js'

describe('max', () => {
    it('gets the maximum value of an array of numbers', () => {
        expect(max([1, 3.5, 3.05])).toBe(3.5)
    })
    it('returns undefined if array is empty', () => {
        expect(max([])).toBe(undefined)
    })
})