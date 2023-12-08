// Specify the data source
int [] scores = { 97, 92, 81, 60, 3, 45, 100 };

// // Define the query expression
IEnumerable<int> scoreQuery = 
    from score in scores
    where score > 80
    orderby score descending // sort the query results
    select score;

List<int> myScores = scoreQuery.ToList();

// method syntax
var scoreQuery2 = scores.Where(s => s > 80).OrderByDescending(s => s);

// IEnumerable<string> scoreQuery = 
//     from score in scores
//     where score > 80
//     orderby score descending
//     select $"The score is {score}";

// Execute the query
foreach (int i in scoreQuery)
{
    Console.Write(i + " ");
}

