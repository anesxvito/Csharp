using System;
using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Adds a key/value pair to the dictionary if the key does not already exist, or returns the existing value.
    /// </summary>
    /// <typeparam name="TKey">The type of the dictionary keys.</typeparam>
    /// <typeparam name="TValue">The type of the dictionary values.</typeparam>
    /// <param name="dictionary">The dictionary to act on.</param>
    /// <param name="key">The key of the element to add.</param>
    /// <param name="value">The value to add if the key does not already exist.</param>
    /// <returns>
    /// The value for the key. This will be either the existing value if the key is already in the dictionary, or
    /// the new value if the key was not in the dictionary.
    /// </returns>
    public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
    {
        if (!dictionary.ContainsKey(key))
        {
            dictionary.Add(key, value);
        }

        return dictionary[key];
    }

    /// <summary>
    /// Adds a key/value pair to the dictionary using the specified factory function if the key does not already exist,
    /// or returns the existing value.
    /// </summary>
    /// <typeparam name="TKey">The type of the dictionary keys.</typeparam>
    /// <typeparam name="TValue">The type of the dictionary values.</typeparam>
    /// <param name="dictionary">The dictionary to act on.</param>
    /// <param name="key">The key of the element to add.</param>
    /// <param name="valueFactory">The function used to generate a value for the key if it does not exist.</param>
    /// <returns>
    /// The value for the key. This will be either the existing value if the key is already in the dictionary, or
    /// the new value generated by the valueFactory if the key was not in the dictionary.
    /// </returns>
    public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TValue> valueFactory)
    {
        if (!dictionary.ContainsKey(key))
        {
            dictionary.Add(key, valueFactory(key));
        }

        return dictionary[key];
    }
}
