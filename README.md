# <h1 align="center"> Finance Control - SOLID </h1>
API with focus to control the financial transaction of a family.

## Design pattern used
 - SOLID;
 - Factory.

## Version 0.02.0

## Funcionality
Can you use the route /api/transactions to register the transaction with some validations to save only data that's in the allowed format.

## Examples

### POST
Route: /api/transactions

**Request Body:**
``` JSON
{
  "type": "D",
  "value": 100.00,
  "category": "Rent"
}
```

## Future Implementations
Credit Cards Transactions - You need to register this transactions apart. <br/>
Users - Create, Read, update and delete. <br/>
Transactions separated by users - You can register all the transactions for differents users.
