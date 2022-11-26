/**
 * Flattens an array into a single array.
 * For example, flattenArray(['this', ['is', 'an'], 'array']) should return ['this', 'is', 'an', 'array']
 * 
 * @param {*} arr The array to flatten
 */
export function flattenArray(arr) {
    // TODO: ISSUE #4242 : Our customer reported that this method doesn't work in the case of deeply nested arrays
    // I added the test case to the spec file, but I'm not sure how to fix it. Can you help?
    // const result = [];
    // for (let i = 0; i < arr.length; i++) {
    //     if (Array.isArray(arr[i])) {
    //         for (let j = 0; j < arr[i].length; j++) {
    //             result.push(arr[i][j]);
    //         }
    //     } else {
    //         result.push(arr[i]);
    //     }
    // }
    const result = arr.flat(Infinity);
    return result;
}