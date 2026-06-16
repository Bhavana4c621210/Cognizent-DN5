# Exercise 1 - Singleton Design Pattern

## Overview

This exercise demonstrates the implementation of the Singleton Design Pattern in Java. The main objective is to ensure that only one instance of the `Logger` class is created and used throughout the application.

## Problem Statement

A logging utility is required in the application to maintain consistent logging. To avoid creating multiple logger objects and to ensure efficient resource usage, the Singleton Design Pattern is implemented.

## Implementation

The `Logger` class contains:

* A private static instance of itself.
* A private constructor to prevent object creation from outside the class.
* A public static method `getInstance()` to provide access to the single instance.
* A logging method to display log messages.

The `SingletonTest` class is used to verify that multiple calls to `getInstance()` return the same object.

## Files Included

* `Logger.java`
* `SingletonTest.java`

## Output

The program verifies that only one instance of the Logger class is created and shared across the application.

## Learning Outcome

Through this exercise, I gained a practical understanding of:

* Singleton Design Pattern
* Object creation control
* Static members and methods
* Real-world usage of design patterns in software development

## Author

Parupalli S D J Sri Bhavana

