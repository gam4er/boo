#region license
// boo - an extensible programming language for the CLI
// Copyright (C) 2004 Rodrigo B. de Oliveira
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// As a special exception, if you link this library with other files to
// produce an executable, this library does not by itself cause the
// resulting executable to be covered by the GNU General Public License.
// This exception does not however invalidate any other reasons why the
// executable file might be covered by the GNU General Public License.
//
// Contact Information
//
// mailto:rbo@acm.org
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by the
// ast.py script on Fri Feb 13 17:14:08 2004
//
using System;

namespace Boo.Lang.Ast
{
	public interface IAstTransformer
	{
		void OnCompileUnit(CompileUnit node, ref CompileUnit newNode);
		void OnSimpleTypeReference(SimpleTypeReference node, ref TypeReference newNode);
		void OnTupleTypeReference(TupleTypeReference node, ref TypeReference newNode);
		void OnNamespaceDeclaration(NamespaceDeclaration node, ref NamespaceDeclaration newNode);
		void OnImport(Import node, ref Import newNode);
		void OnModule(Module node, ref Module newNode);
		void OnClassDefinition(ClassDefinition node, ref ClassDefinition newNode);
		void OnInterfaceDefinition(InterfaceDefinition node, ref InterfaceDefinition newNode);
		void OnEnumDefinition(EnumDefinition node, ref EnumDefinition newNode);
		void OnEnumMember(EnumMember node, ref EnumMember newNode);
		void OnField(Field node, ref Field newNode);
		void OnProperty(Property node, ref Property newNode);
		void OnLocal(Local node, ref Local newNode);
		void OnMethod(Method node, ref Method newNode);
		void OnConstructor(Constructor node, ref Constructor newNode);
		void OnParameterDeclaration(ParameterDeclaration node, ref ParameterDeclaration newNode);
		void OnDeclaration(Declaration node, ref Declaration newNode);
		void OnBlock(Block node, ref Block newNode);
		void OnAttribute(Attribute node, ref Attribute newNode);
		void OnStatementModifier(StatementModifier node, ref StatementModifier newNode);
		void OnDeclarationStatement(DeclarationStatement node, ref Statement newNode);
		void OnAssertStatement(AssertStatement node, ref Statement newNode);
		void OnMacroStatement(MacroStatement node, ref Statement newNode);
		void OnTryStatement(TryStatement node, ref Statement newNode);
		void OnExceptionHandler(ExceptionHandler node, ref ExceptionHandler newNode);
		void OnIfStatement(IfStatement node, ref Statement newNode);
		void OnUnlessStatement(UnlessStatement node, ref Statement newNode);
		void OnForStatement(ForStatement node, ref Statement newNode);
		void OnWhileStatement(WhileStatement node, ref Statement newNode);
		void OnGivenStatement(GivenStatement node, ref Statement newNode);
		void OnWhenClause(WhenClause node, ref WhenClause newNode);
		void OnBreakStatement(BreakStatement node, ref Statement newNode);
		void OnContinueStatement(ContinueStatement node, ref Statement newNode);
		void OnRetryStatement(RetryStatement node, ref Statement newNode);
		void OnReturnStatement(ReturnStatement node, ref Statement newNode);
		void OnYieldStatement(YieldStatement node, ref Statement newNode);
		void OnRaiseStatement(RaiseStatement node, ref Statement newNode);
		void OnUnpackStatement(UnpackStatement node, ref Statement newNode);
		void OnExpressionStatement(ExpressionStatement node, ref Statement newNode);
		void OnOmittedExpression(OmittedExpression node, ref Expression newNode);
		void OnExpressionPair(ExpressionPair node, ref ExpressionPair newNode);
		void OnMethodInvocationExpression(MethodInvocationExpression node, ref Expression newNode);
		void OnUnaryExpression(UnaryExpression node, ref Expression newNode);
		void OnBinaryExpression(BinaryExpression node, ref Expression newNode);
		void OnTernaryExpression(TernaryExpression node, ref Expression newNode);
		void OnReferenceExpression(ReferenceExpression node, ref Expression newNode);
		void OnMemberReferenceExpression(MemberReferenceExpression node, ref Expression newNode);
		void OnStringLiteralExpression(StringLiteralExpression node, ref Expression newNode);
		void OnTimeSpanLiteralExpression(TimeSpanLiteralExpression node, ref Expression newNode);
		void OnIntegerLiteralExpression(IntegerLiteralExpression node, ref Expression newNode);
		void OnRealLiteralExpression(RealLiteralExpression node, ref Expression newNode);
		void OnNullLiteralExpression(NullLiteralExpression node, ref Expression newNode);
		void OnSelfLiteralExpression(SelfLiteralExpression node, ref Expression newNode);
		void OnSuperLiteralExpression(SuperLiteralExpression node, ref Expression newNode);
		void OnBoolLiteralExpression(BoolLiteralExpression node, ref Expression newNode);
		void OnRELiteralExpression(RELiteralExpression node, ref Expression newNode);
		void OnStringFormattingExpression(StringFormattingExpression node, ref Expression newNode);
		void OnHashLiteralExpression(HashLiteralExpression node, ref Expression newNode);
		void OnListLiteralExpression(ListLiteralExpression node, ref Expression newNode);
		void OnTupleLiteralExpression(TupleLiteralExpression node, ref Expression newNode);
		void OnIteratorExpression(IteratorExpression node, ref Expression newNode);
		void OnSlicingExpression(SlicingExpression node, ref Expression newNode);
		void OnAsExpression(AsExpression node, ref Expression newNode);
	}
}
