<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Produit;

class ProduitController extends Controller
{

    public function __construct()
    {
        $this->middleware('auth');
    }

    public function index()
    {
        $produits = Produit::latest()->paginate(5);
        return view('produits.index',compact('produits'))
            ->with('i', (request()->input('page', 1) - 1) * 5);
    }

    public function show($id)
    {
        $produit = Produit::find($id);
        return view('produits.show',compact('produit'));
    }

    public function create()
    {
        return view('produits.create');
    }

    public function store(Request $request)
    {
        request()->validate([
            'libProd' => 'required',
            'prixProd' => 'required',
        ]);
        Produit::create($request->all());
        return redirect()->route('produits.index')
                        ->with('success','Produit created successfully');
    }

    public function edit($idProd)
    {
        $produit = Produit::find($idProd);
        return view('produits.edit',compact('produit'));
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        request()->validate([
            'libProd' => 'required',
            'prixProd' => 'required',
        ]);
        Produit::find($id)->update($request->all());
        return redirect()->route('produits.index')
                        ->with('success','produit updated successfully');
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        Produit::find($id)->delete();
        return redirect()->route('produits.index')
                        ->with('success','produit deleted successfully');
    }
}
