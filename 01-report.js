/**
 * Generates a sales report for the last 12 months based on the monthly data given in the database
 * 
 * @param {Object} database The database of monthly data. The keys are the years, and the values are objects with the keys being the months (1-12) and the values being the sales
 * @returns The sales report for the last 12 months
 */
export function getLast12MonthReport(database) {
    // TODO: This method does not work, I don't know why.
    // Please have a look, I really don't see anything wrong.
    // Note: This one is a bit hard, you will need to use the debugger to understand what is going on, or use the console.log.
    // Please don't get stuck too long on this one, ask for help if you need it.
    // Also, reading the doc might be helpful :D
    const today = new Date();
    let date = new Date(); 
    const year = date.getFullYear();
    let month = date.getMonth();
    // Get back one year
    date.setFullYear(year - 1);
    const outputdata = [];
    while(date <= today) {
        month = date.getMonth();
        month != 0 ? outputdata.push(database[year][month]) :  outputdata.push(database[year][12]);
        date.setMonth(month+1);
        }
        
    return outputdata;
}