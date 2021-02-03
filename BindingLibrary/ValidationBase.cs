using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BindingLibrary
{
    public class ValidationBase : NotifyPropertyBase, INotifyDataErrorInfo
    {
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;
        private readonly Dictionary<string, IEnumerable> _propertyErrors;

        public ValidationBase()
        {
            _propertyErrors = new Dictionary<string, IEnumerable>();
        }

        public bool HasErrors
        {
            get
            {
                if (_propertyErrors == null)
                {
                    return false;
                }
                else
                {
                    return _propertyErrors.Any((x) => x.Value != null && CountErrors(x.Value) > 0);
                }

            }
        }

        public IEnumerable GetErrors(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName))
            {
                return (_propertyErrors.Values);
            }
            else if (_propertyErrors.ContainsKey(propertyName))
            {
                return _propertyErrors[propertyName];
            }
            else
            { return null; }
        }


        /// <summary>
        /// 清除錯誤訊息內容
        /// </summary>
        protected void ClearErrors()
        {
            _propertyErrors.Clear();
        }


        /// <summary>
        /// 計算錯誤訊息的數量
        /// </summary>
        /// <param name="errors"></param>
        /// <returns></returns>
        private int CountErrors(IEnumerable errors)
        {
            if (errors == null)
            {
                return 0;
            }
            int result = 0;
            var enumerator = errors.GetEnumerator();
            while (enumerator.MoveNext())
            {
                result++;
            }
            return result;
        }

        /// <summary>
        /// 設定錯誤訊息
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="propertyName"></param>
        private void SetErrors(IEnumerable errors, string propertyName)
        {
            var count = CountErrors(errors);
            if (count > 0)
            {
                _propertyErrors[propertyName] = errors;
            }
            else
            {
                ClearErrors();
            }
        }


        /// <summary>
        /// 把驗證函式使用委派傳入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storage"></param>
        /// <param name="value"></param>
        /// <param name="validate"></param>
        /// <param name="propertyName"></param>
        protected void SetProperty<T>(ref T storage, T value,
                                      Func<T, IEnumerable> validate,
                                      [CallerMemberName] string propertyName = null)
        {
            SetProperty(ref storage, value, propertyName);
            if (validate != null)
            {
                var errors = validate.Invoke(value);
                SetErrors(errors, propertyName);
            }
        }
    }
}
