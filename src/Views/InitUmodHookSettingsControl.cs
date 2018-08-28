using System;

using uMod.Patcher.Hooks;

namespace uMod.Patcher.Views
{
    public partial class InitModHookSettingsControl : HookSettingsControl
    {
        private bool ignorechanges;

        public InitModHookSettingsControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            InitMod hook = Hook as InitMod;

            ignorechanges = true;
            injectionindex.Value = hook.InjectionIndex;
            ignorechanges = false;
        }

        private void injectionindex_ValueChanged(object sender, EventArgs e)
        {
            if (ignorechanges)
            {
                return;
            }

            InitMod hook = Hook as InitMod;
            hook.InjectionIndex = (int)injectionindex.Value;
            NotifyChanges();
        }
    }
}
