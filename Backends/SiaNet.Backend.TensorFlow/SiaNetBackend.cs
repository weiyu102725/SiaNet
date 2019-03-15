﻿using SiaNet.Engine;
using SiaNet.Engine.Layers;
using System;
using System.Collections.Generic;
using System.Text;
using TensorFlow;
using DeviceType = SiaNet.Engine.DeviceType;

namespace SiaNet.Backend.TensorFlowLib
{
    public class SiaNetBackend : IBackend
    {
        int counter = 0;
        internal TFGraph tf;
        internal TFSession _SESSION;

        public SiaNetBackend()
        {
            this.tf = new TFGraph();
            this._SESSION = new TFSession(tf);
        }

        public static SiaNetBackend Instance
        {
            get
            {
                return new SiaNetBackend();
            }
        }

        private TFOutput In(Tensor x)
        {
            return ((NDArrayTensor)x).InternalTensor;
        }

        private TFOutput In(float value, params long[] shape)
        {
            return tf.Const(new TFTensor(value));
        }

        private NDArrayTensor Out(TFOutput x)
        {
            NDArrayTensor tensor = new NDArrayTensor
            {
                InternalTensor = x
            };

            return tensor;
        }

        public Tensor Abs(Tensor x)
        {
            return Out(tf.Abs(In(x)));
        }

        public Tensor Acos(Tensor x)
        {
            return Out(tf.Acos(In(x)));
        }

        public Tensor Add(Tensor a, Tensor b)
        {
            return Out(tf.Add(In(a), In(b)));
        }

        public Tensor Add(Tensor a, float b)
        {
            return Out(tf.Add(In(a), In(b)));
        }

        public Tensor Add(float a, Tensor b)
        {
            return Out(tf.Add(In(a), In(b)));
        }

        public Tensor Argmax(Tensor x, int dim = 0)
        {
            return Out(tf.ArgMax(In(x), In(dim)));
        }

        public Tensor Argmin(Tensor x, int dim = 0)
        {
            return Out(tf.ArgMin(In(x), In(dim)));
        }

        public Tensor Asin(Tensor x)
        {
            return Out(tf.Asin(In(x)));
        }

        public Tensor Atan(Tensor x)
        {
            return Out(tf.Atan(In(x)));
        }

        public Tensor Atan2(Tensor lhs, Tensor rhs)
        {
            return Out(tf.Atan2(In(lhs), In(rhs)));
        }

        public Tensor Ceil(Tensor x)
        {
            return Out(tf.Ceil(In(x)));
        }

        public Tensor Clip(Tensor x, float min, float max)
        {
            return Out(tf.ClipByValue(In(x), In(min), In(max)));
        }

        public Tensor Col2Im(Tensor cols, long[] x_shape, Tuple<int, int> kernalSize, int padding = 1, int stride = 1)
        {
            throw new NotImplementedException();
        }

        public Tensor Constant(float value, long[] shape)
        {
            throw new NotImplementedException();
        }

        public Tensor Cos(Tensor x)
        {
            return Out(tf.Cos(In(x)));
        }

        public Tensor Cosh(Tensor x)
        {
            return Out(tf.Cosh(In(x)));
        }

        public Tensor CreateVariable(float[] data, long[] shape, string name = "")
        {
            throw new NotImplementedException();
        }

        public Tensor Diag(Tensor x)
        {
            return Out(tf.Diag(In(x)));
        }

        public void Dispose(Tensor x)
        {
            x.Dispose();
        }

        public Tensor Div(Tensor a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public Tensor Div(Tensor a, float b)
        {
            throw new NotImplementedException();
        }

        public Tensor Div(float a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public Tensor Dot(Tensor a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public float Epsilon()
        {
            throw new NotImplementedException();
        }

        public Tensor EqualTo(Tensor a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public object Eval(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Exp(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Floor(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Array GetArray(Tensor x)
        {
            throw new NotImplementedException();
        }

        public DataType GetDataType(Tensor x)
        {
            throw new NotImplementedException();
        }

        public long[] GetShape(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor GreaterThan(Tensor a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public Tensor GreaterThan(float a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public Tensor GreaterThan(Tensor a, float b)
        {
            throw new NotImplementedException();
        }

        public Tensor GreaterThanEqual(Tensor a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public Tensor GreaterThanEqual(float a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public Tensor GreaterThanEqual(Tensor a, float b)
        {
            throw new NotImplementedException();
        }

        public Tensor Im2Col(Tensor x, Tuple<int, int> kernalSize, int padding = 1, int stride = 1)
        {
            throw new NotImplementedException();
        }

        public Tensor L2Normalize(Tensor x, int axis = -1)
        {
            throw new NotImplementedException();
        }

        public Tensor LessThan(Tensor a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public Tensor LessThan(float a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public Tensor LessThan(Tensor a, float b)
        {
            throw new NotImplementedException();
        }

        public Tensor LessThanEqual(Tensor a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public Tensor LessThanEqual(float a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public Tensor LessThanEqual(Tensor a, float b)
        {
            throw new NotImplementedException();
        }

        public Tensor Log(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Log10(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Log1p(Tensor x)
        {
            throw new NotImplementedException();
        }

        public float Max(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Max(Tensor x, int dim)
        {
            throw new NotImplementedException();
        }

        public Tensor Max(Tensor x, params int[] dim)
        {
            throw new NotImplementedException();
        }

        public Tensor Maximum(Tensor a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public Tensor Maximum(Tensor a, float b)
        {
            throw new NotImplementedException();
        }

        public float Mean(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Mean(Tensor x, int dim)
        {
            throw new NotImplementedException();
        }

        public Tensor Mean(Tensor x, params int[] dim)
        {
            throw new NotImplementedException();
        }

        public float Min(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Min(Tensor x, int dim)
        {
            throw new NotImplementedException();
        }

        public Tensor Min(Tensor x, params int[] dim)
        {
            throw new NotImplementedException();
        }

        public Tensor Minimum(Tensor a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public Tensor Minimum(Tensor a, float b)
        {
            throw new NotImplementedException();
        }

        public Tensor Mul(Tensor a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public Tensor Mul(Tensor a, float b)
        {
            throw new NotImplementedException();
        }

        public Tensor Mul(float a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public Tensor Neg(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Pow(Tensor x, float value)
        {
            throw new NotImplementedException();
        }

        public void Print(Tensor x, string title = "")
        {
            throw new NotImplementedException();
        }

        public float Prod(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Prod(Tensor x, int dim)
        {
            throw new NotImplementedException();
        }

        public Tensor Prod(Tensor x, params int[] dim)
        {
            throw new NotImplementedException();
        }

        public Tensor RandomBernoulli(long[] shape, float p)
        {
            throw new NotImplementedException();
        }

        public Tensor RandomNormal(long[] shape, float mean, float stddev, int? seed = null)
        {
            throw new NotImplementedException();
        }

        public Tensor RandomUniform(long[] shape, float min, float max, int? seed = null)
        {
            throw new NotImplementedException();
        }

        public Tensor Reshape(Tensor x, params long[] shape)
        {
            throw new NotImplementedException();
        }

        public Tensor Round(Tensor x)
        {
            throw new NotImplementedException();
        }

        public void SetDevice(DeviceType device)
        {
            throw new NotImplementedException();
        }

        public Tensor Sigmoid(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Sign(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Sin(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Sinh(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor SliceCols(Tensor x, long start, long end)
        {
            throw new NotImplementedException();
        }

        public Tensor SliceRows(Tensor x, long start, long end)
        {
            throw new NotImplementedException();
        }

        public Tensor Softmax(Tensor x, int axis = -1)
        {
            throw new NotImplementedException();
        }

        public Tensor Softplus(Tensor x, int axis = -1)
        {
            throw new NotImplementedException();
        }

        public Tensor Sqrt(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Square(Tensor x)
        {
            throw new NotImplementedException();
        }

        public float StdDev(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor StdDev(Tensor x, int dim)
        {
            throw new NotImplementedException();
        }

        public Tensor StdDev(Tensor x, params int[] dim)
        {
            throw new NotImplementedException();
        }

        public Tensor Sub(Tensor a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public Tensor Sub(Tensor a, float b)
        {
            throw new NotImplementedException();
        }

        public Tensor Sub(float a, Tensor b)
        {
            throw new NotImplementedException();
        }

        public float Sum(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Sum(Tensor x, int dim)
        {
            throw new NotImplementedException();
        }

        public Tensor Sum(Tensor x, params int[] dim)
        {
            throw new NotImplementedException();
        }

        public Tensor Tan(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Tanh(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Tile(Tensor x, int n, int axis = 0)
        {
            throw new NotImplementedException();
        }

        public Tensor Tpow(float value, Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Transpose(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Transpose(Tensor x, params int[] dims)
        {
            throw new NotImplementedException();
        }

        public Tensor Trunc(Tensor x)
        {
            throw new NotImplementedException();
        }

        public string UUID(string name)
        {
            throw new NotImplementedException();
        }

        public float Var(Tensor x)
        {
            throw new NotImplementedException();
        }

        public Tensor Var(Tensor x, int dim)
        {
            throw new NotImplementedException();
        }

        public Tensor Var(Tensor x, params int[] dim)
        {
            throw new NotImplementedException();
        }

        public ActivationFunc GetActFunc()
        {
            throw new NotImplementedException();
        }
    }
}