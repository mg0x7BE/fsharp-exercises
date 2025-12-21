// 034-project-csv-parser.fsx

// PROJECT: CSV Sales Data Analyzer
// You work for a small company and need to analyze sales data from a CSV file.
// The CSV contains: ProductName, Category, Price, Quantity

(*
SAMPLE CSV DATA (save this as "sales.csv" or use it as a string):

ProductName,Category,Price,Quantity
Laptop,Electronics,999.99,5
Mouse,Electronics,25.50,15
Desk,Furniture,299.99,3
Chair,Furniture,150.00,8
Keyboard,Electronics,75.00,12
Monitor,Electronics,350.00,6
Table,Furniture,450.00,2

*)

// YOUR TASKS:

// Part 1: Data Modeling
// 1. Create a type alias for Price (float) and Quantity (int)
// 2. Create a record type SalesRecord with fields:
//    - ProductName: string
//    - Category: string
//    - Price: Price
//    - Quantity: Quantity


// Part 2: CSV Parsing
// 3. Write a function parseLine that:
//    - Takes a CSV line as string (e.g. "Laptop,Electronics,999.99,5")
//    - Splits it by comma (use line.Split(','))
//    - Returns Some SalesRecord if valid, None if invalid
//    - Hint: Use pattern matching on the array
//    - Hint: Use System.Double.TryParse for price, System.Int32.TryParse for quantity
//
// 4. Write a function parseCSV that:
//    - Takes a list of lines (skip the header line)
//    - Uses List.choose with parseLine to get only valid records
//    - Returns list of SalesRecord


// Part 3: Data Analysis
// 5. Calculate total revenue (price * quantity for all products)
//
// 6. Find the most expensive product (highest price)
//    - Return Option<SalesRecord> (Some if found, None if empty list)
//
// 7. Group products by Category and calculate:
//    - Total revenue per category
//    - Product count per category
//    - Result: list of (Category, TotalRevenue, ProductCount)
//
// 8. Find top 3 products by revenue (price * quantity)
//    - Sort by revenue descending
//    - Take first 3


// Part 4: Output
// 9. Print all results in a nice format:
//    - Total Revenue: $X.XX
//    - Most Expensive: ProductName ($X.XX)
//    - Revenue by Category:
//      - Electronics: $X.XX (Y products)
//      - Furniture: $X.XX (Y products)
//    - Top 3 Products by Revenue:
//      1. ProductName: $X.XX
//      2. ProductName: $X.XX
//      3. ProductName: $X.XX


// SAMPLE DATA (you can use this instead of reading a file):
let csvData = """ProductName,Category,Price,Quantity
Laptop,Electronics,999.99,5
Mouse,Electronics,25.50,15
Desk,Furniture,299.99,3
Chair,Furniture,150.00,8
Monitor,Electronics,350.00,6
Keyboard,Electronics,75.00,12
Table,Furniture,450.00,2"""


// HINTS:
// - To split CSV into lines: csvData.Split('\n') |> Array.toList
// - To skip header: list |> List.tail
// - To split line by comma: line.Split(',')
// - Array access: arr.[0], arr.[1], etc.
// - TryParse returns (bool, value) tuple
// - Revenue = price * quantity


// EXPECTED OUTPUT:
(*
Total Revenue: $16182.33
Most Expensive: Laptop ($999.99)

Revenue by Category:
  Electronics: $11582.33 (4 products)
  Furniture: $4600.00 (3 products)

Top 3 Products by Revenue:
  1. Laptop: $4999.95
  2. Monitor: $2100.00
  3. Keyboard: $900.00
*)