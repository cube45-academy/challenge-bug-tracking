/**
 * Flattens an array into a single array.
 * For example, flattenArray(['this', ['is', 'an'], 'array']) should return ['this', 'is', 'an', 'array']
 * 
 * This is an equivalent of Array.prototype.flat(), but
 * our customer is using an old browser that does not support it,
 * so we have to implement it here.
 * 
 * @param {*} arr The array to flatten
 */
export function flattenArray(arr) {
    return arr.reduce(function (flat, toFlatten) {
        return flat.concat(Array.isArray(toFlatten) ? flattenArray(toFlatten) : toFlatten);
    }, []);
}