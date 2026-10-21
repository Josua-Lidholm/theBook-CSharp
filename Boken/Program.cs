// See https://aka.ms/new-console-template for more information

using Boken;

Book book1 = new Book("Pippi Långstrump", "Astrid Lindgren", 75);
Book book2 = new Book("Livet måste ha mening", "Viktor Frankl", 160);
Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);

book1.Describe();
book2.Describe();
book3.Describe();