﻿namespace LGM.Domain.Exceptions.Base;
public abstract class DomainException : BaseException
{
    protected DomainException(string message) : base(message)
    {

    }
}