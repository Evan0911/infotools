@extends('layout')

@section('content')
    <div class="row">
        <div class="col-lg-12 margin-tb">
            <div class="pull-right">
            <!-- un bouton appel la page commandes.create -->
                <a class="btn btn-success" href="{{ route('commandes.create') }}"> Create New Commande</a>
            </div>
        </div>
    </div>

    <!-- si on reçoit un paramètre succès on affiche un message de succès -->
    @if ($message = Session::get('success'))
        <div class="alert alert-success">
            <p>{{ $message }}</p>
        </div>
    @endif


    <!-- table commande -->
    <h3>Table commandes</h3>
    <table class="table table-bordered">
        <tr>
            <th>Numéro commande</th>
            <th>Nom Client</th>
            <th>Le</th>
            <th width="280px">Action</th>
        </tr>

        <!-- on parcourt la liste commandes donné en paramètre
        les crochets servent à remplacer la balise php -->
    @foreach ($commandes as $commande)
    <tr>
        <td>{{ ++$i }}</td>
        <td>{{ $commande->client->nomCli . " " .  $commande->client->prenomCli}}</td>
        <td>{{ $commande->created_at}}</td>
        <td>
            <a class="btn btn-info" href="{{ route('commandes.show',$commande->id) }}">Show</a>
            <a class="btn btn-primary" href="{{ route('commandes.edit',$commande->id) }}">Edit</a>
            <!-- on ouvre un formulaire qui, avec le bouton, supprime le commande -->
            {!! Form::open(['method' => 'DELETE','route' => ['commandes.destroy', $commande->id],'style'=>'display:inline']) !!}
            {!! Form::submit('Delete', ['class' => 'btn btn-danger']) !!}
            {!! Form::close() !!}
        </td>
    </tr>
    @endforeach
    </table>

    {!! $commandes->links() !!}
@endsection