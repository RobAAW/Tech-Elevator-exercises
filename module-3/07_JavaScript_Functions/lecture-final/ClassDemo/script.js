function multiplyBy() {
    let result = arguments[0] * arguments[1];
    return result;
}

function concatAll()
{
    let result = '';
    for(let i = 0; i < arguments.length; i++)
    {
        result += "," + arguments[i];
    }
    return result;
}

let numbers = [1,2,3,4,5,6];
let evenNumbers = numbers.filter((item) => {
    return item % 2 === 0;
})
console.table(numbers);
console.table(evenNumbers);

function foreEachDemo()
{
    let numbers = [1,2,3,4,5,6];
    let result = [];
    numbers.forEach((item) => {
        console.log('The square of ' + item + ' is ' + (item * item))
        result.push(item * item);
    })
    console.table(result);
}

function mapDemo()
{
    let numbers = [9,8,7,6,5,4,3,2,1];
    let squares = numbers.map((item) => {
        if((item * item)% 4 === 0)
        {
            return `The square of ${item} is ${item * item}`;
        } else {
            return item * item
        }
    })
    console.table(numbers);
    console.table(squares);
}

function reduceDemo()
{
    let nameParts = ['eddie','angel','anderson'];
    let fullName = nameParts.reduce((result,part) => {
        return result + ' ' + part.substring(0,1).toLocaleUpperCase() + part.substring(1);
    },'');
    console.log(fullName.trim());
}

function reduceDemo2()
{
    let numbers = [9,8,7,6,5,4,3,2,1,0];
    // sum up the even numbers
    let sumEven = numbers.reduce((sum,part) => {
        if(part % 2 === 0)
        {
            return sum += part;
        }
        return sum;
    });
    // no initial value uses the first value from the array.
    console.log(sumEven);
}