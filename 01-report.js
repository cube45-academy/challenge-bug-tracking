export function getLast12MonthReport(database) {
    // TODO: This method does not work, I don't know why.
    // Please have a look, I really don't see anything wrong.
    // Note: This one is a bit hard, you will need to use the debugger to understand what is going on, or use the console.log.
    // Please don't get stuck too long on this one, ask for help if you need it.
    // Also, reading the doc might be helpful :D
    const today = new Date();
    const d = new Date();
    const year = d.getFullYear();
    // Get back one year
    d.setFullYear(year - 1);
    const data = [];
    while(d < today) {
        const month = d.getMonth();
        data.push(database[year][month]);
        d.setMonth(month + 1);
    }
    return data;
}