// See https://aka.ms/new-console-template for more information
using ReverseTreeDesignPattern;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

ReverseNode rTree = new ReverseNode();
rTree.BuildTree(5);

Debug.Assert(rTree.CountNodes() == 9, "test failed result isn't 9!");
rTree.BuildTree(1);
Debug.Assert(rTree.CountNodes() == 1, "test failed result isn't 1!");
rTree.BuildTree(2);
Debug.Assert(rTree.CountNodes() == 3, "test failed result isn't 3!");
