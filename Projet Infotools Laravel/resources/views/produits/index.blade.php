@extends('layout')

@section('content')
    @if (Auth::user()->is_admin == 0)
        <div class="row">
            <div class="col-lg-12 margin-tb">
                <div class="pull-left">
                    <h2>Produit</h2>
                </div>
            </div>
        </div>

        <!-- si on reçoit un paramètre succès on affiche un message de succès -->
        @if ($message = Session::get('success'))
            <div class="alert alert-success">
                <p>{{ $message }}</p>
            </div>
        @endif

        <table class="table table-bordered">
            <tr>
                <th>No</th>
                <th>Libellé</th>
                <th>Prix</th>
            </tr>

            <!-- on parcourt la liste produits donné en paramètre
            les crochets servent à remplacer la balise php -->
        @foreach ($produits as $produit)
        <tr>
            <td>{{ ++$i }}</td>
            <td>{{ $produit->libProd}}</td>
            <td>{{ $produit->prixProd . " "}}</td>
        </tr>
        @endforeach
        </table>

        <!-- seulement si paginate !!!-->
        {!! $produits->links() !!}
    @else
        <div class="row">
            <div class="col-lg-12 margin-tb">
                <div class="pull-left">
                    <h2>Produit</h2>
                </div>
                <div class="pull-right">
                <!-- un bouton appel la page produits.create -->
                    <a class="btn btn-success" href="{{ route('produits.create') }}"> Create New produit</a>
                </div>
            </div>
        </div>

        <!-- si on reçoit un paramètre succès on affiche un message de succès -->
        @if ($message = Session::get('success'))
            <div class="alert alert-success">
                <p>{{ $message }}</p>
            </div>
        @endif

        <table class="table table-bordered">
            <tr>
                <th>No</th>
                <th>Libellé</th>
                <th>Prix</th>
                <th width="280px">Action</th>
            </tr>

            <!-- on parcourt la liste produits donné en paramètre
            les crochets servent à remplacer la balise php -->
        @foreach ($produits as $produit)
        <tr>
            <td>{{ ++$i }}</td>
            <td>{{ $produit->libProd}}</td>
            <td>{{ $produit->prixProd . " "}}</td>
            <td>
                <!--<a class="btn btn-info" href="{{ route('produits.show',$produit->id) }}">Show</a>-->
                <a class="btn btn-primary" href="{{ route('produits.edit',$produit->id) }}">Edit</a>
                <!-- on ouvre un formulaire qui, avec le bouton, supprime le produit -->
                {!! Form::open(['method' => 'DELETE','route' => ['produits.destroy', $produit->id],'style'=>'display:inline']) !!}
                {!! Form::submit('Delete', ['class' => 'btn btn-danger']) !!}
                {!! Form::close() !!}
            </td>
        </tr>
        @endforeach
        </table>

        <!-- seulement si paginate !!!-->
        {!! $produits->links() !!}
    @endif
@endsection