| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;

public static partial class Extensions
{
    /// <summary>
    ///     An object extension method that converts this object to an u int 32 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>The given data converted to an uint.</returns>
    public static uint ToUInt32OrDefault(this object @this)
    {
        try
        {
            return Convert.ToUInt32(@this);
        }
        catch (Exception)
        {
            return default(uint);
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to an u int 32 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <returns>The given data converted to an uint.</returns>
    public static uint ToUInt32OrDefault(this object @this, uint defaultValue)
    {
        try
        {
            return Convert.ToUInt32(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    /// An object extension method that converts this object to an u int 32 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValue">The default value.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to an uint.</returns>
    public static uint ToUInt32OrDefault(this object @this, uint defaultValue, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null)
        {
            return defaultValue;
        }

        try
        {
            return Convert.ToUInt32(@this);
        }
        catch (Exception)
        {
            return defaultValue;
        }
    }

    /// <summary>
    ///     An object extension method that converts this object to an u int 32 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <returns>The given data converted to an uint.</returns>
    public static uint ToUInt32OrDefault(this object @this, Func<uint> defaultValueFactory)
    {
        try
        {
            return Convert.ToUInt32(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }

    /// <summary>
    /// An object extension method that converts this object to an u int 32 or default.
    /// </summary>
    /// <param name="this">The @this to act on.</param>
    /// <param name="defaultValueFactory">The default value factory.</param>
    /// <param name="useDefaultIfNull">true to use default if null.</param>
    /// <returns>The given data converted to an uint.</returns>
    public static uint ToUInt32OrDefault(this object @this, Func<uint> defaultValueFactory, bool useDefaultIfNull)
    {
        if (useDefaultIfNull && @this == null)
        {
            return defaultValueFactory();
        }

        try
        {
            return Convert.ToUInt32(@this);
        }
        catch (Exception)
        {
            return defaultValueFactory();
        }
    }
}