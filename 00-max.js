export function max(array) {
  if (!array || array.length === 0) return undefined;
  else return Math.max(...array);
}
