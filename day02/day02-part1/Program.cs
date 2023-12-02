// See https://aka.ms/new-console-template for more information

using AoC2023_lib;
using day02_lib;

var result = InputLoader
    .LoadFileAsLines("input.txt")
    .Select(Part1.ParseGameFromLine)
    .Where(game => Part1.IsGamePossible(game, 12, 13, 14))
    .Sum(game => game.Id);
    
Console.WriteLine("Day 02 Part 1:");
Console.WriteLine($"{result}");