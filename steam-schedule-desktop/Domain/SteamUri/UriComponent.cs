using System.Collections.Generic;
using System.Dynamic;

namespace steam_schedule_desktop.Domain.SteamUri
{
    //This is an abomination that shouldn't exist. I'm sorry. But it looks cool when you use it :D
    public class UriComponent: DynamicObject
    {
        private readonly UriComponent? _parent;
        private readonly string _uri;
        protected readonly Dictionary<string, UriComponent> _children;

        public UriComponent(UriComponent? parent, string uri)
        {
            _parent = parent;
            _uri = uri;
            _children = new();
        }

        public string GetUri()
        {
            if (_parent == null)
            {
                return $"{_uri}:/";
            }
            else
            {
                return $"{_parent.GetUri()}/{_uri}";
            }
        }

        public override bool TrySetMember(SetMemberBinder binder, object? value)
        {
            _children[binder.Name] = (UriComponent)value!;

            return true;
        }

        public override bool TryGetMember(GetMemberBinder binder, out object? result)
        {
            if (!_children.ContainsKey(binder.Name))
            {
                result = new UriComponent(this, binder.Name.ToLower());
                _children[binder.Name] = (UriComponent)result;
                return true;
            } else
            {
                result = _children[binder.Name];
                return true;
            }
        }
    }
}
