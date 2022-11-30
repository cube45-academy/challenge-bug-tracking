import { getLast12MonthReport } from '../01-report.js'

// Generates data for the database. Assume this is correct
function generateDatabase() {
    const database = {};
    const d = new Date();
    for(let y = d.getFullYear() - 2; y <= d.getFullYear(); y++) {
        database[y] = {};
        for(let m = 1; m <= ((y === d.getFullYear()) ? d.getMonth() : 12); m++) {
            database[y][m] = Math.floor(Math.random() * 1000);
        }
    }
    return database
}

// This test is done twice : Once with the current date, and once with a special date in the past.
for(const testLeapYear of [false, true]) {
    describe('getLast12MonthReport' + (testLeapYear ? ' with leap year' : ''), () => {
        if(testLeapYear) {
            beforeAll(() => {
                jasmine.clock().install();
                var baseTime = new Date(2020, 1, 29);
                jasmine.clock().mockDate(baseTime);
            })
            afterAll(() => {
                jasmine.clock().uninstall();
            })
        }
        it('must have exactly 12 month', () => {
            expect(getLast12MonthReport(generateDatabase()).length).toBe(12)
        })
        it('must not have any undefined month', () => {
            expect(getLast12MonthReport(generateDatabase()).some(x => x === undefined)).toBe(false)
        })
        it('must return a list of month ending with the last month', () => {
            // If we are in november 2022, it should give the result of october 2022
            const database = generateDatabase();
            const report = getLast12MonthReport(database)
            const date = new Date()
            date.setDate(0)// This is a hack to get the last day of the previous month
            expect(report[report.length - 1]).toEqual(database[date.getFullYear()][date.getMonth() + 1])
        })
    })
}