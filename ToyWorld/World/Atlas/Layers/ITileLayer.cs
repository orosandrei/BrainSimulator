﻿using System;
using System.Diagnostics.Contracts;
using VRageMath;
using World.GameActors;
using World.GameActors.Tiles;
using World.Physics;

namespace World.Atlas.Layers
{
    [ContractClass(typeof(TileLayerContracts))]
    public interface ITileLayer : ILayer<Tile>
    {
        /// <summary>
        /// Updates any internal states of tiles within the layer.
        /// </summary>
        /// <param name="atlas"></param>
        void UpdateTileStates(Atlas atlas);

        /// <summary>
        /// Returns Tiles in given region, where extremes are included.
        /// </summary>
        /// <param name="rectangle"></param>
        int[] GetRectangle(Rectangle rectangle);

        /// <summary>
        /// Returns Tiles in given region, where x1 &lt; x2, y1 &lt; y2. x2 and y2 included.
        /// </summary>
        /// <param name="size"></param>
        /// <param name="pos"></param>
        int[] GetRectangle(Vector2I pos, Vector2I size);


        int Width { get; set; }

        int Height { get; set; }
    }


    [ContractClassFor(typeof(ITileLayer))]
    internal abstract class TileLayerContracts : ITileLayer
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public bool Render { get; set; }
        public LayerType LayerType { get; set; }


        public Tile GetActorAt(int x, int y)
        {
            if (x < 0)
                throw new ArgumentOutOfRangeException("x", "x has to be positive");
            if (y < 0)
                throw new ArgumentOutOfRangeException("y", "y has to be positive");
            Contract.EndContractBlock();

            return default(Tile);
        }

        public Tile GetActorAt(Vector2I position)
        {
            return GetActorAt(position.X, position.Y);
        }

        public bool ReplaceWith<TR>(GameActorPosition original, TR replacement)
        {
            return default(bool);
        }

        public bool Add(GameActorPosition gameActorPosition)
        {
            return default(bool);
        }

        public void UpdateTileStates(Atlas atlas)
        { }

        public int[] GetRectangle(Rectangle rectangle)
        {
            if (rectangle.Size.X <= 0 && rectangle.Size.Y <= 0)
                throw new ArgumentOutOfRangeException("rectangle", "values doesn't form a valid rectangle");
            Contract.EndContractBlock();

            return default(int[]);
        }

        public int[] GetRectangle(Vector2I pos, Vector2I size)
        {
            if (size.X <= 0 && size.Y <= 0)
                throw new ArgumentOutOfRangeException("size", "size values doesn't form a valid rectangle");
            Contract.EndContractBlock();

            return default(int[]);
        }
    }
}
