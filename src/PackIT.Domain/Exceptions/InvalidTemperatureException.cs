﻿using PackIT.Shared.Exceptions;

namespace PackIT.Domain.Exceptions;

public class InvalidTemperatureException : PackItException
{
    public double Value { get; }

    public InvalidTemperatureException(double value) : base($"Value '{value}' is invalid temperature.")
        => Value = value;
}