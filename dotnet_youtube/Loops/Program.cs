int counter = 0;

// optimized for counting
while (counter < 5) {
    Console.WriteLine(counter);
    counter++;
}

// do while loops will always run at least once
do {
    Console.WriteLine(counter);
    counter++;
} while (counter < 5);


for (int i = 0; i < 5; i++) {
    if (i == 3) {
        Console.WriteLine(i);
    }
}