using Hihierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    public class OldMan : Person, IMovable
    {
        #region Events

        public event EventHandler OnGotOldManWelcomePhrase;

        #endregion

        #region Properties

        /// <summary>
        /// Максимальная скорость передвижения.
        /// </summary>
        public double MaxSpeed { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Возвращает приветственную фразу.
        /// </summary>
        /// <returns></returns>
        public override string GetWelcomePhrase()
        {
            OnGotOldManWelcomePhrase?.Invoke(this, new EventArgs());
            return "Всех категорически приветсвую";
        }

        #endregion
    }
}
