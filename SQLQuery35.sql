SELECT orderid, orderdate, custid, empid
FROM Sales.Orders
WHERE YEAR(orderdate) = 2015 AND MONTH(orderdate) = 6;
But, better this
SELECT orderid, orderdate, custid, empid
FROM Sales.Orders
WHERE orderdate >= '2015-06-01'
AND orderdate < '2015-07-01';