// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System;

namespace osu.Framework.Testing.Drawables.StepButtons
{
    public class SingleStepButton : StepButton
    {
        public new Action Action;

        public SingleStepButton()
        {
            base.Action = () =>
            {
                Action?.Invoke();
                Success();
            };
        }


    }
}