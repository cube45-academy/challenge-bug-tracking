import { flattenArray } from '../02-flatten-array.js'

describe('flatten-array', () => {
    it('Should return an empty array if source is empty', () => {
        expect(flattenArray([])).toEqual([])
    })
    it('Should flatten the example array', () => {
        expect(flattenArray(['this', ['is', 'an'], 'array'])).toEqual(['this', 'is', 'an', 'array'])
    })
    it('Should flatten deeply nested array', () => {
        expect(flattenArray(['this', ['is', 'a', [[['super'], 'nested']]], 'array'])).toEqual(['this', 'is', 'a', 'super', 'nested', 'array'])
    })
})