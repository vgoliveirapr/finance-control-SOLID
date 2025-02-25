# <h1 align="center"> Finance Control - SOLID </h1>
API with focus to control the financial transaction of a family.

## Design pattern used
 - SOLID;
 - Fabric.

## Version 0.01.0

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
A database with the transaction because today is only in the local variable.
