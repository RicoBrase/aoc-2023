// See https://aka.ms/new-console-template for more information

using AoC2023_lib;
using day01_lib;

var input = InputLoader.LoadFileAsLines("input.txt");
var result = input
    .Select(Part1.ProcessSingleLine)
    .Sum();
    
    Console.WriteLine("Day 01 Part 1:");
    Console.WriteLine($"{result}");