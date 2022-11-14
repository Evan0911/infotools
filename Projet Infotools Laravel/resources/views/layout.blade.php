<!DOCTYPE html>
<html>
<head>
	<title>InfoTools</title>
	<link href="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.0.0-alpha/css/bootstrap.css" rel="stylesheet">
	<div class="pull-left">
		<a class="btn btn-success" href="{{ route('clients.index') }}">Clients</a>
		<a class="btn btn-success" href="{{ route('produits.index') }}">Produits</a>
		<!--<a class="btn btn-success" href="{{ route('commandes.index') }}">Commandes</a>-->
	</div>
	<div class="text-right">
	@guest
            <a class="btn btn-success" href="{{ route('login') }}">{{ __('Login') }}</a>
        @if (Route::has('register'))
            <a class="btn btn-success" href="{{ route('register') }}">{{ __('Register') }}</a>
        @endif
        @else
                <a class="dropdown-item" href="{{ route('logout') }}"
                    onclick="event.preventDefault();
                        document.getElementById('logout-form').submit();">
                            {{ __('Logout') }}
                </a>

                <form id="logout-form" action="{{ route('logout') }}" method="POST" style="display: none;">
                @csrf
            	</form>
        @endguest
	</div>
	
</head>
<body>

<div class="container">
    @yield('content')
</div>

</body>
</html>