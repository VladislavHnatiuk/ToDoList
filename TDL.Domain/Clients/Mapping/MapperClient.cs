namespace TDL.Domain.Clients.Mapping
{
    using AutoMapper;

    using System.Collections.Generic;

    /// <summary>
    /// Useful client for use automapper libraries classes.
    /// </summary>
    internal static class MapperClient
    {
        /// <summary>
        /// Map one instance type into another type.
        /// </summary>
        /// <typeparam name="TSource">Source instance type.</typeparam>
        /// <typeparam name="TDestination">Destination instance type.</typeparam>
        /// <param name="source">Source instance.</param>
        /// <returns>Destination instance.</returns>
        internal static TDestination Map<TSource, TDestination>(TSource source)
        {
            // Configure that mapper should map TSource into TDestination.
            var mapperCfg = new MapperConfiguration(cfg => cfg.CreateMap<TSource, TDestination>());

            // Automapper creation.
            var mapper = new Mapper(mapperCfg);

            // Mapping TSource into TDestination.
            var entity = mapper.Map<TDestination>(source);
            return entity;
        }

        /// <summary>
        /// Map one collection instances type into another type.
        /// </summary>
        /// <typeparam name="TSource">Source instance type.</typeparam>
        /// <typeparam name="TDestination">Destination instance type.</typeparam>
        /// <param name="enumerable">Source collection of instances.</param>
        /// <returns>Destination collection of instances.</returns>
        internal static IEnumerable<TDestination> Map<TSource, TDestination>(IEnumerable<TSource> enumerable)
        {
            // Configure that mapper should map TSource into TDestination.
            var mapperCfg = new MapperConfiguration(cfg => cfg.CreateMap<TSource, TDestination>());

            // Automapper creation.
            var mapper = new Mapper(mapperCfg);

            // Mapping TSource into TDestination.
            var entity = mapper.Map<List<TDestination>>(enumerable);
            return entity;
        }
    }
}
