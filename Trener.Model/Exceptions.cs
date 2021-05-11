using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trener.Model
{
    [Serializable]
    public class IncompleteDataException : Exception
    {
    }

    [Serializable]
    public class NonexistantIdException : Exception
    {
    }

    [Serializable]
    public class OibAlreadyTakenException : Exception
    {
    }

    [Serializable]
    public class NonexistantOibException : Exception
    {
    }

    [Serializable]
    public class NameAlreadyTakenException : Exception
    {
    }

    [Serializable]
    public class NonexistantNameException : Exception
    {
    }

    [Serializable]
    public class PeriodAlreadyTakenException : Exception
    {
    }

    [Serializable]
    public class DependantDataNotDeletableException : Exception
    {
    }
}