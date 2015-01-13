//-------------------------------------------------------------------------------
// <copyright file="IQuestion{TAnswer}.cs" company="Appccelerate">
//   Copyright (c) 2008-2015
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Appccelerate.EvaluationEngine
{
    using System.Reflection;

    /// <summary>
    /// A question that can be asked.
    /// </summary>
    /// <typeparam name="TAnswer">The type of the answer.</typeparam>
    public interface IQuestion<TAnswer> : IQuestion<TAnswer, Missing>
    {
    }

    /// <summary>
    /// A question that can be asked.
    /// </summary>
    /// <typeparam name="TAnswer">The type of the answer.</typeparam>
    /// <typeparam name="TParameter">The type of the parameter.</typeparam>
    // ReSharper disable UnusedTypeParameter because they are used as markers
    public interface IQuestion<TAnswer, TParameter> : IDescriptionProvider
    // ReSharper restore UnusedTypeParameter
    {
    }
}