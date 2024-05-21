﻿namespace ShortR.Application.Common.Exceptions;

public class NotFoundException(string code, string? message = null, Exception? inner = null)
    : Exception(message, inner)
{
    public string Code { get; } = code;
}
