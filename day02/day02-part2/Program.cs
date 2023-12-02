// See https://aka.ms/new-console-template for more information

using AoC2023_lib;
using day02_lib;

var result = InputLoader
    .LoadFileAsLines("input.txt")
    .Select(Part1.ParseGameFromLine)
    .Select(Part2.FindMinimumCubesForPossibleGame)
    .Select(Part2.GetGameSetPower)
    .Sum();
    
Console.WriteLine("Day 02 Part 2:");
Console.WriteLine($"{result}");