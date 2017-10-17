using System;

namespace Faust.DTO
{
    public interface IDTOMapper<T>
    {
        Func<T> Map();
    }
    public interface IDTOMapper<T1, T2>
    {
        Func<T1, T2> Map();
    }
    public interface IDTOMapper<T1, T2, T3>
    {
        Func<T1, T2, T3> Map();
    }
    public interface IDTOMapper<T1, T2, T3, T4>
    {
        Func<T1, T2, T3, T4> Map();
    }
    public interface IDTOMapper<T1, T2, T3, T4, T5>
    {
        Func<T1, T2, T3, T4, T5> Map();
    }
    public interface IDTOMapper<T1, T2, T3, T4, T5, T6>
    {
        Func<T1, T2, T3, T4, T5, T6> Map();
    }
    public interface IDTOMapper<T1, T2, T3, T4, T5, T6, T7>
    {
        Func<T1, T2, T3, T4, T5, T6, T7> Map();
    }
    public interface IDTOMapper<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        Func<T1, T2, T3, T4, T5, T6, T7, T8> Map();
    }
    public interface IDTOMapper<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> Map();
    }
    public interface IDTOMapper<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Map();
    }
}
