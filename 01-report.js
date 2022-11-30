/**
 * Generates a sales report for the last 12 months based on the monthly data given in the database
 * 
 * @param {Object} database The database of monthly data. The keys are the years, and the values are objects with the keys being the months (1-12) and the values being the sales
 * @returns The sales report for the last 12 months
 */
export function getLast12MonthReport(database) {
    const today = new Date();
    const d = new Date();
    //Hack to set the day to be the 2nd of the month on normal years, and the first on leap yars
    today.setDate(2);
    d.setDate(2);
    // Get back one year
    d.setFullYear(d.getFullYear() -1);
    const data = [];
    while(d < today) {
        const month = d.getMonth();
        data.push(database[d.getFullYear()][month +1]);
        d.setMonth(month +1);
    }
    return data;
}